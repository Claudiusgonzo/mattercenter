// <copyright file="GlobalSuppressions.cs" company="Microsoft">
//     Copyright (c) . All rights reserved.
// </copyright>
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Assembly cannot be signed with strong key")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Legal.MatterCenter.Common.ErrorMessage.ShowMessage(System.String,Microsoft.Legal.MatterCenter.Common.ErrorMessage+MessageType)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateListPermissions.Program.#Main(System.String[])", Justification = "Suppressing since the code will not be localized")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateListPermissions.Program.#UpdateSendMailListPermissions(Microsoft.SharePoint.Client.ClientContext,System.Collections.Generic.Dictionary`2<System.String,System.String>)", Justification ="Method or Class can not be further subdivided")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Console.Write(System.String)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.UpdateListPermissions.Program.#UpdateSendMailListPermissions(Microsoft.SharePoint.Client.ClientContext,System.Collections.Generic.Dictionary`2<System.String,System.String>)", Justification = "Suppressing since the code will not be localized")]
