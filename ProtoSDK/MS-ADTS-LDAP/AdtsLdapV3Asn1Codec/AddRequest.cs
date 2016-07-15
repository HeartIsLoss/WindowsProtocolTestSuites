// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Protocols.TestTools.StackSdk.Asn1;

namespace Microsoft.Protocols.TestTools.StackSdk.ActiveDirectory.Adts.Asn1CodecV3
{
    /*
    AddRequest ::= [APPLICATION 8] SEQUENCE {
                entry           LDAPDN,
                attributes      AttributeList }
    */
    [Asn1Tag(Asn1TagType.Application, 8)]
    public class AddRequest : Asn1Sequence
    {
        [Asn1Field(0)]
        public LDAPDN entry { get; set; }
        
        [Asn1Field(1)]
        public AttributeList attributes { get; set; }
        
        public AddRequest()
        {
            this.entry = null;
            this.attributes = null;
        }
        
        public AddRequest(
         LDAPDN entry,
         AttributeList attributes)
        {
            this.entry = entry;
            this.attributes = attributes;
        }
    }
}

