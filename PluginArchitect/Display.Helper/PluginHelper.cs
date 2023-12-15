using System.Reflection;

namespace Display.Helper
{
    public static class PluginHelper
    {
        public static List<Plug> GetPlugins(string selectedPath)
        {
            ArgumentException.ThrowIfNullOrEmpty(nameof(selectedPath));
            if (!Directory.Exists(selectedPath))
            {
                throw new FileNotFoundException("klasör bulunamadı");
            }

            List<Plug> plugins = getPluginsFromPath(selectedPath);
            return plugins;
        }

        private static List<Plug> getPluginsFromPath(string selectedPath)
        {
            //1. belirtilen klasör içindeki .dll dosyalarını bul:
            var dllFiles = Directory.GetFiles(selectedPath, "*.dll");
            List<Plug> plugs = new List<Plug>();
            dllFiles.ToList().ForEach(file => plugs = addReference(file));
            return plugs;
        }

        private static List<Plug> addReference(string file)
        {
            //2. .dll dosyalarını projeye referans olarak ekle:
            var assembly = Assembly.LoadFile(file);
            var types = assembly.GetTypes();
            List<Plug> plugs = new List<Plug>();
            types.ToList().ForEach(type =>
            {
                Plug plug = handShakeForApp(type, file);
                if (plug is not null)
                {
                    plugs.Add(plug);
                }

            });

            return plugs;

        }

        private static Plug handShakeForApp(Type type, string file)
        {
            //3. Tip'in bizim plugin'imiz olup olmadığını kontrol et:
            Plug plug = null;
            if (type.GetInterface("IPlugin") is not null)
            {
                plug = new Plug { FullPath = file, FullName = type.FullName };
                dynamic instance = Activator.CreateInstance(type);

                // plug.Name = instance.GetType().GetProperty("Name").GetValue(instance).ToString();
                plug.Name = instance.Name;

                dynamic value = "string";


            }

            return plug;
        }

        public static IPlugin CreateInstance(Plug p)
        {
            Assembly assembly = Assembly.LoadFile(p.FullPath);
            var instance = assembly.CreateInstance(p.FullName);
            return (IPlugin)instance;
        }
    }
}
