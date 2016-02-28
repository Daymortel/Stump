﻿using System;
using System.Linq;
using Stump.DofusProtocol.Enums;
using Stump.Server.WorldServer.Database.Jobs;
using Stump.Server.WorldServer.Game.Actors.RolePlay.Characters;
using Stump.Server.WorldServer.Handlers.Inventory;

namespace Stump.Server.WorldServer.Game.Dialogs.Jobs
{
    public class JobIndexDialog : IDialog
    {
        private JobTemplate m_lastRequestedJob;

        public JobIndexDialog(Character character, JobTemplate[] jobs)
        {
            Character = character;
            Jobs = jobs;
        }

        public Character Character
        {
            get;
            private set;
        }

        public JobTemplate[] Jobs
        {
            get;
            private set;
        }

        public DialogTypeEnum DialogType
        {
            get { return DialogTypeEnum.DIALOG_EXCHANGE; }
        }

        public void Open()
        {
            InventoryHandler.SendExchangeStartOkJobIndexMessage(Character.Client, Jobs);
            Character.SetDialog(this);
        }

        public void RequestAvailableCrafters(int jobId)
        {
            var job = Jobs.FirstOrDefault(x => x.Id == jobId);

            if (job != null)
                RequestAvailableCrafters(job);
        }

        public void RequestAvailableCrafters(JobTemplate job)
        {
            if (m_lastRequestedJob != null)
            {
                m_lastRequestedJob.CrafterUnSubscribed -= LastRequestedJobOnCrafterUnSubscribed;
                m_lastRequestedJob.CrafterSubscribed -= LastRequestedJobOnCrafterSubscribed;
            }

            m_lastRequestedJob = job;
            m_lastRequestedJob.CrafterUnSubscribed += LastRequestedJobOnCrafterUnSubscribed;
            m_lastRequestedJob.CrafterSubscribed += LastRequestedJobOnCrafterSubscribed;

            InventoryHandler.SendJobCrafterDirectoryListMessage(Character.Client, job.AvailableCrafters.Select(x => x.Jobs[job.Id]));
        }

        private void LastRequestedJobOnCrafterSubscribed(JobTemplate jobTemplate, Character character)
        {
            InventoryHandler.SendJobCrafterDirectoryAddMessage(Character.Client, character.Jobs[jobTemplate.Id]);
        }

        private void LastRequestedJobOnCrafterUnSubscribed(JobTemplate jobTemplate, Character character)
        {
            InventoryHandler.SendJobCrafterDirectoryRemoveMessage(Character.Client, character.Jobs[jobTemplate.Id]);
        }

        public void Close()
        {
            if (m_lastRequestedJob != null)
            {
                m_lastRequestedJob.CrafterUnSubscribed -= LastRequestedJobOnCrafterUnSubscribed;
                m_lastRequestedJob.CrafterSubscribed -= LastRequestedJobOnCrafterSubscribed;
            }
            Character.ResetDialog();
        }
    }
}