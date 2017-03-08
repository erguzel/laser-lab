using System;
using Abstraction.Core;
using System.Collections;
using System.Collections.Generic;

namespace Abstraction.Laserlab
{
    public interface IPicturable 
    {
        IEnumerable<IPicture> Pictures { get; set; }
    }
    public interface IDocumentable
    {
        IEnumerable<IDocument> Documents { get; set; }
    }

    public interface ILuminescence
    {

    }

}
