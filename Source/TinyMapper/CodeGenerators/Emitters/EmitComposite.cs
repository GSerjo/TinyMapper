﻿using System.Collections.Generic;
using Nelibur.Mapper.Core.Extensions;

namespace Nelibur.Mapper.CodeGenerators.Emitters
{
    internal sealed class EmitComposite : IEmitter
    {
        private readonly List<IEmitter> _nodes = new List<IEmitter>();

        public EmitComposite Add(IEmitter node)
        {
            if (node.IsNotNull())
            {
                _nodes.Add(node);
            }
            return this;
        }

        public void Emit(CodeGenerator generator)
        {
            _nodes.ForEach(x => x.Emit(generator));
        }
    }
}
