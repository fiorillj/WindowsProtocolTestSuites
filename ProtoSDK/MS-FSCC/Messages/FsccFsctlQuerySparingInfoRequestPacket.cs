// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Fscc
{
    /// <summary>
    /// the request packet of FSCTL_QUERY_SPARING_INFO 
    /// </summary>
    public class FsccFsctlQuerySparingInfoRequestPacket : FsccEmptyPacket
    {
        #region Properties

        /// <summary>
        /// the command of fscc packet 
        /// </summary>
        public override uint Command
        {
            get
            {
                return (uint)FsControlCommand.FSCTL_QUERY_SPARING_INFO;
            }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// default constructor 
        /// </summary>
        public FsccFsctlQuerySparingInfoRequestPacket()
            : base()
        {
        }


        #endregion
    }
}
