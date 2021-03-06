﻿using GameLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic.States
{
    public interface IState
    {
        IState AddPlayer(Player player);
        IState StartGame();
        IState VotePlayerReady(string playerConnId);
        IState CheckIfMafia(string myConnID);
        IState ProtectPlayer(string myConnID, string connID);
        IState VoteMafiaKills(string playerConnId, string toBeKilledConnId);
        IState VoteDiscussionFinished(string playerConnId);
        IState VoteMain(string playerConnId, string toBeVotedConnId);
        IState VoteDraw(string playerConnId, string toBeVotedConnId);
        IState VoteReadyForNextRound(string playerConnId);
        bool HaveMafiaWon();
    }
}
