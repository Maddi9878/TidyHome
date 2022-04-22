﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.Custom;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(WhatWeDoRepeater.CLASS_NAME, typeof(WhatWeDoRepeater))]

namespace CMS.DocumentEngine.Types.Custom
{
	/// <summary>
	/// Represents a content item of type WhatWeDoRepeater.
	/// </summary>
	public partial class WhatWeDoRepeater : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "custom.WhatWeDoRepeater";


		/// <summary>
		/// The instance of the class that provides extended API for working with WhatWeDoRepeater fields.
		/// </summary>
		private readonly WhatWeDoRepeaterFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// WhatWeDoRepeaterID.
		/// </summary>
		[DatabaseIDField]
		public int WhatWeDoRepeaterID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("WhatWeDoRepeaterID"), 0);
			}
			set
			{
				SetValue("WhatWeDoRepeaterID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// anchor.
		/// </summary>
		[DatabaseField]
		public string anchor
		{
			get
			{
				return ValidationHelper.GetString(GetValue("anchor"), @"");
			}
			set
			{
				SetValue("anchor", value);
			}
		}


		/// <summary>
		/// Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), @"");
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string Title
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Title"), @"");
			}
			set
			{
				SetValue("Title", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with WhatWeDoRepeater fields.
		/// </summary>
		[RegisterProperty]
		public WhatWeDoRepeaterFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with WhatWeDoRepeater fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class WhatWeDoRepeaterFields : AbstractHierarchicalObject<WhatWeDoRepeaterFields>
		{
			/// <summary>
			/// The content item of type WhatWeDoRepeater that is a target of the extended API.
			/// </summary>
			private readonly WhatWeDoRepeater mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="WhatWeDoRepeaterFields" /> class with the specified content item of type WhatWeDoRepeater.
			/// </summary>
			/// <param name="instance">The content item of type WhatWeDoRepeater that is a target of the extended API.</param>
			public WhatWeDoRepeaterFields(WhatWeDoRepeater instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// WhatWeDoRepeaterID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.WhatWeDoRepeaterID;
				}
				set
				{
					mInstance.WhatWeDoRepeaterID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}


			/// <summary>
			/// anchor.
			/// </summary>
			public string anchor
			{
				get
				{
					return mInstance.anchor;
				}
				set
				{
					mInstance.anchor = value;
				}
			}


			/// <summary>
			/// Image.
			/// </summary>
			public string Image
			{
				get
				{
					return mInstance.Image;
				}
				set
				{
					mInstance.Image = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.Title;
				}
				set
				{
					mInstance.Title = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="WhatWeDoRepeater" /> class.
		/// </summary>
		public WhatWeDoRepeater() : base(CLASS_NAME)
		{
			mFields = new WhatWeDoRepeaterFields(this);
		}

		#endregion
	}
}