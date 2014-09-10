﻿//    #[license]
//    SmartsheetClient SDK for C#
//    %%
//    Copyright (C) 2014 SmartsheetClient
//    %%
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        
//            http://www.apache.org/licenses/LICENSE-2.0
//        
//    Unless required by applicable law or agreed To in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//    %[license]

using System.Collections.Generic;

namespace Smartsheet.Api.Models
{


	/// <summary>
	/// Represents the Home object. </summary>
	/// <seealso href="http://help.Smartsheet.com/customer/portal/articles/522237-the-home-tab">Home Tab Help</seealso>
	public class Home
	{
		/// <summary>
		/// Represents the Sheets in the home location.
		/// </summary>
		private IList<Sheet> sheets;

		/// <summary>
		/// Represents the Folders in the home location.
		/// </summary>
		private IList<Folder> folders;

		// <summary>
		// Represents the reports in the home location.
		// </summary>
		//TODO: implement reports
		// private List<Report> reports;

		/// <summary>
		/// Represents the Templates in the home location.
		/// </summary>
		private IList<Template> templates;

		/// <summary>
		/// Represents the Workspaces in the home location.
		/// </summary>
		private IList<Workspace> workspaces;

		/// <summary>
		/// Gets the Sheets in the home location.
		/// </summary>
		/// <returns> the Sheets </returns>
		public virtual IList<Sheet> Sheets
		{
			get
			{
				return sheets;
			}
			set
			{
				this.sheets = value;
			}
		}


		/// <summary>
		/// Gets the Folders in the home location.
		/// </summary>
		/// <returns> the Folders </returns>
		public virtual IList<Folder> Folders
		{
			get
			{
				return folders;
			}
			set
			{
				this.folders = value;
			}
		}


		/// <summary>
		/// Gets the Templates in the home location.
		/// </summary>
		/// <returns> the Templates </returns>
		public virtual IList<Template> Templates
		{
			get
			{
				return templates;
			}
			set
			{
				this.templates = value;
			}
		}


		/// <summary>
		/// Gets the Workspaces in the home location.
		/// </summary>
		/// <returns> the Workspaces </returns>
		public virtual IList<Workspace> Workspaces
		{
			get
			{
				return workspaces;
			}
			set
			{
				this.workspaces = value;
			}
		}

	}

}