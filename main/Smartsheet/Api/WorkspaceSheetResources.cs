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

namespace Smartsheet.Api
{
	using Api.Models;

	/// <summary>
	/// <para>This interface provides methods To access Sheet resources that are associated To a workspace object.</para>
	/// 
	/// <para>Thread Safety: Implementation of this interface must be thread safe.</para>
	/// </summary>
	public interface WorkspaceSheetResources
	{
		/// <summary>
		/// <para>Creates a sheet in the given workspace.</para>
		/// 
		/// <para>It mirrors To the following Smartsheet REST API method: POST /workspaces/{workspaceId}/Sheets</para>
		/// </summary>
		/// <param name="workspaceId"> the workspace Id </param>
		/// <param name="sheet"> the sheet To create </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheet(long workspaceId, Sheet sheet);

		/// <summary>
		/// <para>Creates a Sheet at the top-level of the specified Workspace, from the specified Template. </para>
		/// <para>It mirrors To the following Smartsheet REST API method: POST /workspaces/{workspaceId}/Sheets</para>
		/// </summary>
		/// <param name="workspaceId"> the workspace Id </param>
		/// <param name="sheet"> the sheet To create </param>
		/// <param name="includes"> used To specify the optional objects To include </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="System.InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due To rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheetFromTemplate(long workspaceId, Sheet sheet, IEnumerable<TemplateInclusion> includes);
	}
}