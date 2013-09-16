#region Copyright & License summary
/*
 Copyright 2013, James M. Curran, Novel Theory Software

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
#endregion

using System.Collections.Generic;

namespace Shakespeare.Ast
{
    public class CharacterListNode : ShakespeareBaseAstNode
    {
        public void Fill(ICollection<CharacterNode> coll)
        {
            foreach (var cn in TreeNode.ChildNodes)
            {
                if (cn != null)
                    coll.Add(cn.AstNode as CharacterNode);
            }
        }
    }
}