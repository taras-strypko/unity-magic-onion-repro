// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace ClientLib.MagicOnion
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

        public static void Register()
        {
            if(isRegistered) return;
            isRegistered = true;

            MagicOnionClientRegistry<ClientLib.IMyFirstService>.Register((x, y, z) => new ClientLib.MyFirstServiceClient(x, y, z));

        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace ClientLib.MagicOnion.Resolvers
{
    using System;
    using MessagePack;

    public class MagicOnionResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new MagicOnionResolver();

        MagicOnionResolver()
        {

        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = MagicOnionResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class MagicOnionResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static MagicOnionResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(1)
            {
                {typeof(global::MagicOnion.DynamicArgumentTuple<int, int>), 0 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MagicOnion.DynamicArgumentTupleFormatter<int, int>(default(int), default(int));
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace ClientLib {
    using System;
    using Grpc.Core;
    using MessagePack;
    using global::MagicOnion.Client;
    using global::MagicOnion;

    [Ignore]
    public class MyFirstServiceClient : MagicOnionClientBase<global::ClientLib.IMyFirstService>, global::ClientLib.IMyFirstService
    {
        static readonly Method<byte[], byte[]> SumAsyncMethod;
        static readonly Func<RequestContext, ResponseContext> SumAsyncDelegate;

        static MyFirstServiceClient()
        {
            SumAsyncMethod = new Method<byte[], byte[]>(MethodType.Unary, "IMyFirstService", "SumAsync", MagicOnionMarshallers.ThroughMarshaller, MagicOnionMarshallers.ThroughMarshaller);
            SumAsyncDelegate = _SumAsync;
        }

        MyFirstServiceClient()
        {
        }

        public MyFirstServiceClient(CallInvoker callInvoker, MessagePackSerializerOptions serializerOptions, IClientFilter[] filters)
            : base(callInvoker, serializerOptions, filters)
        {
        }

        protected override MagicOnionClientBase<IMyFirstService> Clone()
        {
            var clone = new MyFirstServiceClient();
            clone.host = this.host;
            clone.option = this.option;
            clone.callInvoker = this.callInvoker;
            clone.serializerOptions = this.serializerOptions;
            clone.filters = filters;
            return clone;
        }

        public new IMyFirstService WithHeaders(Metadata headers)
        {
            return base.WithHeaders(headers);
        }

        public new IMyFirstService WithCancellationToken(System.Threading.CancellationToken cancellationToken)
        {
            return base.WithCancellationToken(cancellationToken);
        }

        public new IMyFirstService WithDeadline(System.DateTime deadline)
        {
            return base.WithDeadline(deadline);
        }

        public new IMyFirstService WithHost(string host)
        {
            return base.WithHost(host);
        }

        public new IMyFirstService WithOptions(CallOptions option)
        {
            return base.WithOptions(option);
        }
   
        static ResponseContext _SumAsync(RequestContext __context)
        {
            return CreateResponseContext<DynamicArgumentTuple<int, int>, int>(__context, SumAsyncMethod);
        }

        public global::MagicOnion.UnaryResult<int> SumAsync(int x, int y)
        {
            return InvokeAsync<DynamicArgumentTuple<int, int>, int>("IMyFirstService/SumAsync", new DynamicArgumentTuple<int, int>(x, y), SumAsyncDelegate);
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
