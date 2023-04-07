using Microsoft.SemanticKernel.Orchestration;
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
        public virtual string Input { get; set; }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual string Output { get; set; }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual Exception? LastException { get; set; }
    }

    public class SenaprcAiResult<T> : SenparcAiResult, IAiResult
    {
        public T Result { get; set; }
    }

    public class SenaprcContentAiResult : SenaprcAiResult<SKContext>, IAiResult
    {
        public SKContext Result { get; set; }
    }
}