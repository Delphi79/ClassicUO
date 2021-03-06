#region license

// Copyright (c) 2021, andreakarasho
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 1. Redistributions of source code must retain the above copyright
//    notice, this list of conditions and the following disclaimer.
// 2. Redistributions in binary form must reproduce the above copyright
//    notice, this list of conditions and the following disclaimer in the
//    documentation and/or other materials provided with the distribution.
// 3. All advertising materials mentioning features or use of this software
//    must display the following acknowledgement:
//    This product includes software developed by andreakarasho - https://github.com/andreakarasho
// 4. Neither the name of the copyright holder nor the
//    names of its contributors may be used to endorse or promote products
//    derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS ''AS IS'' AND ANY
// EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE FOR ANY
// DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion

using System;
using System.IO;
using System.Runtime.Serialization;
using ClassicUO.IO.Audio.MP3Sharp.Support;

namespace ClassicUO.IO.Audio.MP3Sharp
{
    /// <summary>
    ///     MP3SharpException is the base class for all API-level
    ///     exceptions thrown by MP3Sharp. To facilitate conversion and
    ///     common handling of exceptions from other domains, the class
    ///     can delegate some functionality to a contained Throwable instance.
    /// </summary>
    [Serializable]
    public class MP3SharpException : Exception
    {
        public MP3SharpException()
        {
        }

        public MP3SharpException(string message) : base(message)
        {
        }

        public MP3SharpException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MP3SharpException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public void PrintStackTrace()
        {
            SupportClass.WriteStackTrace(this, Console.Error);
        }

        public void PrintStackTrace(StreamWriter ps)
        {
            if (InnerException == null)
            {
                SupportClass.WriteStackTrace(this, ps);
            }
            else
            {
                SupportClass.WriteStackTrace(InnerException, Console.Error);
            }
        }
    }
}