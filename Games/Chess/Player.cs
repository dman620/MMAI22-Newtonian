// Generated by Creer at 04:13PM on December 01, 2015 UTC, git hash: '1b69e788060071d644dd7b8745dca107577844e1'
// A player in this game. Every AI controls one player.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Chess
{
    /// <summary>
    /// A player in this game. Every AI controls one player.
    /// </summary>
    class Player : Chess.GameObject
    {
        #region Properties
        /// <summary>
        /// What type of client this is, e.g. 'Python', 'JavaScript', or some other language. For potential data mining purposes.
        /// </summary>
        public string ClientType { get; protected set; }

        /// <summary>
        /// The color (side) of this player. Either 'White' or 'Black', with the 'White' player having the first move.
        /// </summary>
        public Chess.String Color { get; protected set; }

        /// <summary>
        /// The direction your checkers must go along the file (y) axis until they reach the other side.
        /// </summary>
        public int FileDirection { get; protected set; }

        /// <summary>
        /// true if this player is currently in check, and must move out of check.
        /// </summary>
        public bool InCheck { get; protected set; }

        /// <summary>
        /// if the player lost the game or not
        /// </summary>
        public bool Lost { get; protected set; }

        /// <summary>
        /// If the Player has made thier move for the turn. true means they can no longer move a piece this turn.
        /// </summary>
        public bool MadeMove { get; protected set; }

        /// <summary>
        /// The name of the player
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// this player's opponent in the game.
        /// </summary>
        public Chess.Player OtherPlayer { get; protected set; }

        /// <summary>
        /// All the unpcaptured chess pieces owned by this player.
        /// </summary>
        public IList<Chess.Piece> Pieces { get; protected set; }

        /// <summary>
        /// the reason why the player lost the game
        /// </summary>
        public string ReasonLost { get; protected set; }

        /// <summary>
        /// the reason why the player won the game
        /// </summary>
        public string ReasonWon { get; protected set; }

        /// <summary>
        /// The amount of time (in ns) remaining for this AI to send commands.
        /// </summary>
        public float TimeRemaining { get; protected set; }

        /// <summary>
        /// if the player won the game or not
        /// </summary>
        public bool Won { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of {$obj_key}. Used during game initialization, do not call directly.
        /// </summary>
        protected Player() : base()
        {
            this.Pieces = new List<Chess.Piece>();
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
