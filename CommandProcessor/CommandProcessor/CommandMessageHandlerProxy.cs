using System;
using System.Linq.Expressions;

namespace CommandProcessor.CommandProcessor
{
    public class CommandMessageHandlerProxy : ICommandMessageHandler
    {
        private static readonly Action<object, object> ExecuteHandler = (message, commandHandler) =>
                                                                  {
                                                                      var methodName = GetMethodName<ICommandHandler<object>>(m => m.Execute(null));
                                                                      var method = commandHandler.GetType().GetMethod(methodName);
                                                                      method.Invoke(commandHandler, new[] { message });
                                                                  };

        private readonly ICommandHandler _command;

        public CommandMessageHandlerProxy(ICommandHandler command)
        {
            _command = command;
        }

        public void Execute(object commandMessage)
        {
            ExecuteHandler(commandMessage, _command);
        }

        private static string GetMethodName<T>(Expression<Action<T>> expression)
        {
            var memberExpression = expression.Body as MethodCallExpression;
            return memberExpression.Method.Name;
        }
    }
}