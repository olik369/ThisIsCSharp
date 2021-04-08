using System;
using static System.Console;
using System.Collections.Generic;

namespace chp14.NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach(var iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }
        private class ItemValue
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)   //중첩클래스에서 상위클래스에 자유롭게 접근 가능
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            { return item; }
            public string GetValue()
            { return value; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            WriteLine(config.GetConfig("Version"));
            WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            WriteLine(config.GetConfig("Version"));
        }
    }
}
