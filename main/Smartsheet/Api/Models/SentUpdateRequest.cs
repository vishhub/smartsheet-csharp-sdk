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

using System;
using System.Collections.Generic;

namespace Smartsheet.Api.Models
{
	/// <summary>
	/// Represents the SentUpdateRequest object./// </summary>
	/// <seealso href="http://smartsheet-platform.github.io/api-docs/#sentupdaterequest-object">SentUpdateRequest Documentation</seealso>
	public class SentUpdateRequest : IdentifiableModel
	{
		/// <summary>
		/// ID of the originating update request.
		/// </summary>
		private long? updateRequestId;

		/// <summary>
		/// The date and time for when the sent update request was sent to the recipient.
		/// </summary>
		private DateTime sentAt;

		/// <summary>
		/// User object containing name and email of the sender.
		/// </summary>
		private User sentBy;

		/// <summary>
		/// The status of the sent update request.
		/// </summary>
		private UpdateRequestStatus? status; 

		/// <summary>
		/// IDs of rows update is requested.
		/// </summary>
		private IList<long> rowIds;

		/// <summary>
		/// IDs of columns included in the request.
		/// </summary>
		private IList<long> columnIds;

		/// <summary>
		/// A flag to indicate whether or not the Attachments were included in the email.
		/// </summary>
		private bool? includeAttachments;

		/// <summary>
		/// A flag to indicate whether or not the Discussions were included in the email.
		/// </summary>
		private bool? includeDiscussions;

		/// <summary>
		/// Recipient object.
		/// </summary>
		private Recipient sentTo;

		/// <summary>
		/// The subject of the email.
		/// </summary>
		private string subject;
		
		/// <summary>
		/// The message of the email.
		/// </summary>
		private string message;

		/// <summary>
		/// Get the ID of the originating update request.
		/// </summary>
		/// <returns> the update request Id </returns>
		public virtual long? UpdateRequestId
		{
			get
			{
				return updateRequestId;
			}
			set
			{
				this.updateRequestId = value;
			}
		}

		/// <summary>
		/// Get the date and time for when the sent update request was sent to the recipient.
		/// </summary>
		/// <returns> the timestamp </returns>
		public virtual DateTime SentAt
		{
			get
			{
				return sentAt;
			}
			set
			{
				this.sentAt = value;
			}
		}

		/// <summary>
		/// Gets the User object containing name and email of the sender.
		/// </summary>
		/// <returns> the User </returns>
		public virtual User SentBy
		{
			get
			{
				return sentBy;
			}
			set
			{
				this.sentBy = value;
			}
		}

		/// <summary>
		/// Gets the status of the sent update request.
		/// </summary>
		/// <returns> the UpdateRequestStatus </returns>
		public virtual UpdateRequestStatus? Status
		{
			get
			{
				return status;
			}
			set
			{
				this.status = value;
			}
		}

		/// <summary>
		/// IDs of rows update is requested.
		/// </summary>
		public virtual IList<long> RowIds
		{
			get 
			{ 
				return rowIds; 
			}
			set 
			{ 
				this.rowIds = value; 
			}
		}

		/// <summary>
		/// IDs of columns included in the request.
		/// </summary>
		public virtual IList<long> ColumnIds
		{
			get 
			{ 
				return columnIds; 
			}
			set 
			{ 
				columnIds = value; 
			}
		}

		/// <summary>
		/// Gets the flag that indicates if Attachments should be included in the Email.
		/// </summary>
		/// <returns> the include Attachments </returns>
		public virtual bool? IncludeAttachments
		{
			get
			{
				return includeAttachments;
			}
			set
			{
				this.includeAttachments = value;
			}
		}

		/// <summary>
		/// Gets the flag that indicates if Discussions should be included in the Email.
		/// </summary>
		/// <returns> the include Discussions </returns>
		public virtual bool? IncludeDiscussions
		{
			get
			{
				return includeDiscussions;
			}
			set
			{
				this.includeDiscussions = value;
			}
		}

		/// <summary>
		/// Gets the Recipient
		/// </summary>
		/// <returns> the Recipients </returns>
		public virtual Recipient SentTo
		{
			get
			{
				return sentTo;
			}
			set
			{
				this.sentTo = value;
			}
		}

		/// <summary>
		/// Gets the Subject.
		/// </summary>
		/// <returns> the Subject </returns>
		public virtual string Subject
		{
			get
			{
				return subject;
			}
			set
			{
				this.subject = value;
			}
		}

		/// <summary>
		/// Gets the Message.
		/// </summary>
		/// <returns> the Message </returns>
		public virtual string Message
		{
			get
			{
				return message;
			}
			set
			{
				this.message = value;
			}
		}
	}
}
