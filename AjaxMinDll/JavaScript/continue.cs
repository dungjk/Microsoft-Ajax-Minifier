// continue.cs
//
// Copyright 2010 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Text;

namespace Microsoft.Ajax.Utilities
{

    public sealed class ContinueNode : AstNode
    {
        public string Label { get; set; }
        public int NestLevel { get; private set; }

        public ContinueNode(Context context, JSParser parser, int count, string label)
            : base(context, parser)
        {
            Label = (label == null || label.Length == 0) ? null : label;
            NestLevel = count;
        }

        public override void Accept(IVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }
    }
}