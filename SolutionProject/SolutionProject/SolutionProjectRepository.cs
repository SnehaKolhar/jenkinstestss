﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SolutionProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the SolutionProjectRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a94ef4b5-1631-49ff-8ced-83daddec96d4")]
    public partial class SolutionProjectRepository : RepoGenBaseFolder
    {
        static SolutionProjectRepository instance = new SolutionProjectRepository();

        /// <summary>
        /// Gets the singleton class instance representing the SolutionProjectRepository element repository.
        /// </summary>
        [RepositoryFolder("a94ef4b5-1631-49ff-8ced-83daddec96d4")]
        public static SolutionProjectRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public SolutionProjectRepository() 
            : base("SolutionProjectRepository", "/", null, 0, false, "a94ef4b5-1631-49ff-8ced-83daddec96d4", ".\\RepositoryImages\\SolutionProjectRepositorya94ef4b5.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a94ef4b5-1631-49ff-8ced-83daddec96d4")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class SolutionProjectRepositoryFolders
    {
    }
#pragma warning restore 0436
}
