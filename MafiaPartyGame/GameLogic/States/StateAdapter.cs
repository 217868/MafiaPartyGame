﻿using GameLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.States
{
    public class StateAdapter : IState
    {
        protected GameData gameData;

        public StateAdapter(GameData gameData)
        {
            this.gameData = gameData;
        }

        public virtual IState AddPlayer(Player player)
        {
            return this;
        }

        public virtual IState CheckIfMafia(string myConnID)
        {
            return this;
        }

        public virtual bool HaveMafiaWon()
        {
            return false;
        }

        public virtual IState ProtectPlayer(string myConnID, string connID)
        {
            return this;
        }

        public virtual IState StartGame()
        {
            return this;
        }

        public virtual IState VoteDiscussionFinished(string playerConnId)
        {
            return this;
        }

        public virtual IState VoteDraw(string playerConnId, string toBeVotedConnId)
        {
            return this;
        }

        public virtual IState VoteMafiaKills(string playerConnId, string toBeKilledConnId)
        {
            return this;
        }

        public virtual IState VoteMain(string playerConnId, string toBeVotedConnId)
        {
            return this;
        }

        public virtual IState VotePlayerReady(string playerConnId)
        {
            return this;
        }

        public virtual IState VoteReadyForNextRound(string playerConnId)
        {
            return this;
        }
    }
}
