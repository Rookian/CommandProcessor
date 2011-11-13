using System;
using System.Collections.Generic;

namespace CommandProcessor.CommandProcessor
{
    public interface ICommandMessageHandlerFactory
    {
        IEnumerable<ICommandMessageHandler> GetCommands(Type messageType);
    }
}