namespace POC.Factory
{
    using Api.Services;
    using Api.Services.Impl;
    using Unity;

    public static class FactoryApi<T> where T : class
    {
        private static IUnityContainer containerT = null;

        public static T Create(string Type)
        {
            if (containerT == null)
            {

                containerT = new UnityContainer();
                containerT.RegisterType<ITransaction, Transaction>(Type);

            }

            return containerT.Resolve<T>(Type);
        }
    }
}
