using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HEEEEEEEEEEEEEEEEEEEEEEEEEEEELP.UIElement
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
