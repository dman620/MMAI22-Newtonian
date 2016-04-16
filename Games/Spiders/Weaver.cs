// Generated by Creer at 12:46AM on April 16, 2016 UTC, git hash: 'f74143f3f89eebeaa381aba30a8afbda7d0e1d89'
// A Spiderling that can alter existing Webs by weaving to add or remove silk from the Webs, thus altering its strength.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Spiders
{
    /// <summary>
    /// A Spiderling that can alter existing Webs by weaving to add or remove silk from the Webs, thus altering its strength.
    /// </summary>
    class Weaver : Spiders.Spiderling
    {
        #region Properties
        /// <summary>
        /// The Web that this Weaver is strengthening. Null if not strengthening.
        /// </summary>
        public Spiders.Web StrengtheningWeb { get; protected set; }

        /// <summary>
        /// The Web that this Weaver is weakening. Null if not weakening.
        /// </summary>
        public Spiders.Web WeakeningWeb { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Weaver. Used during game initialization, do not call directly.
        /// </summary>
        protected Weaver() : base()
        {
        }

        /// <summary>
        /// Weaves more silk into an existing Web to strengthen it.
        /// </summary>
        /// <param name="web">The web you want to strengthen. Must be connected to the Nest this Weaver is currently on.</param>
        /// <returns>True if the strengthen was successfully started, false otherwise.</returns>
        public bool Strengthen(Spiders.Web web)
        {
            return this.RunOnServer<bool>("strengthen", new Dictionary<string, object> {
                {"web", web}
            });
        }

        /// <summary>
        /// Weaves more silk into an existing Web to strengthen it.
        /// </summary>
        /// <param name="web">The web you want to weaken. Must be connected to the Nest this Weaver is currently on.</param>
        /// <returns>True if the weaken was successfully started, false otherwise.</returns>
        public bool Weaken(Spiders.Web web)
        {
            return this.RunOnServer<bool>("weaken", new Dictionary<string, object> {
                {"web", web}
            });
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
