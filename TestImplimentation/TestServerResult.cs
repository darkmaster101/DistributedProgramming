﻿using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces.Server;
using Interfaces.Shared;

namespace TestImplimentation
{
	public class TestServerResult  :IServerResult
	{
		public TestServerResult (
			TimeSpan timeTaken, 
			IDictionary<IClient, IResult> clientResults,
			bool success,
			IJob request
		)
		{
			TimeTaken = timeTaken;
			ClientResults = clientResults;
			Success = success;
			request = Request;
		}

		public TimeSpan TimeTaken {
			get;
			private set;
		}

		public IDictionary<IClient, IResult> ClientResults {
			get;
			private set;
		}

		public bool Success {
			get;
			private set;
		}

		public IDictionary<string, string> Result {
			get {
				var firstSuccess = ClientResults.Values.FirstOrDefault (r => r.Success);
				if (null == firstSuccess) {
					throw new InvalidOperationException ("No results");
				}

				return firstSuccess.Result;
			}
		}

		public IJob Request {
			get;
			private set;
		}
				
	}
}

