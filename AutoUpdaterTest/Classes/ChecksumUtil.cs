using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdaterTest.Classes
{
	public class ChecksumUtil
	{
		public static HashingAlgoTypes AlgorithmType { get; set; }

        public enum HashingAlgoTypes
		{
			MD5,
			SHA1,
			SHA256,
			SHA384,
			SHA512,
			None
		}

		public static string GetChecksum(HashingAlgoTypes hashingAlgoType, string filename)
		{
			using (var hasher = System.Security.Cryptography.HashAlgorithm.Create(hashingAlgoType.ToString()))
			{
				using (var stream = System.IO.File.OpenRead(filename))
				{
					var hash = hasher.ComputeHash(stream);
					return BitConverter.ToString(hash).Replace("-", "");
				}
			}
		}

    }
}
