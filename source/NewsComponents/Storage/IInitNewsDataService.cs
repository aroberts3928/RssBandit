﻿#region Version Info Header
/*
 * $Id$
 * $HeadURL$
 * Last modified by $Author$
 * Last modified at $Date$
 * $Revision$
 */
#endregion


namespace NewsComponents.Storage
{
	/// <summary>
	/// Data service initialization interface
	/// </summary>
	public interface IInitNewsDataService
	{
		/// <summary>
		/// Initializes the data service with the specified initialization data.
		/// </summary>
		/// <param name="initData">The initialization data. 
		/// Can be a connection string, or a file path; 
		/// depending on the implementation of the data service</param>
		void Initialize(string initData);
	}
}