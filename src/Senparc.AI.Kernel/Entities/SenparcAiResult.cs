using Senparc.AI.Interfaces;
using System;

namespace Senparc.AI.Kernel
{
    /// <summary>
    /// Senparc.AI.Kernel ģ��� AI �ӿڷ�����Ϣ
    /// </summary>
    public class SenparcAiResult : IAiResult
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Input { get; set; }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Output { get; set; }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Exception? LastException { get; set; }
    }
}