﻿using System;
using Interfaces.Shared;
using System.Collections.Generic;

namespace Helpers.Internal
{
	internal class InternalResult : IResult
	{
		public InternalResult ()
		{
		}

		public InternalResult (IResult result)
		{
			Success = result.Success;
			Result = result.Result;
			Request = result.Request;
		}

		public bool Success {
			get;
			set;
		}

		public IDictionary<string, string> Result {
			get;
			set;
		}

		public IJob Request {
			get;
			set;
		}

	}
}

