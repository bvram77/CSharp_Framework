using System;
using System.Collections.Generic;

namespace com.venkat.framework.selenium
{

    public sealed class Browser
    {
        public static readonly Browser Firefox = new Browser("Firefox", InnerEnum.Firefox, "Firefox");
        public static readonly Browser Chrome = new Browser("Chrome", InnerEnum.Chrome, "Chrome");
        public static readonly Browser IE = new Browser("IE", InnerEnum.IE, "IE");
        public static readonly Browser Edge = new Browser("Edge", InnerEnum.Edge, "Edge");
        public static readonly Browser HtmlUnit = new Browser("HtmlUnit", InnerEnum.HtmlUnit, "HtmlUnit");
        public static readonly Browser Safari = new Browser("Safari", InnerEnum.Safari, "Safari");
        public static readonly Browser PhantomJS = new Browser("PhantomJS", InnerEnum.PhantomJS, "PhantomJS");
        public static readonly Browser Opera = new Browser("Opera", InnerEnum.Opera, "Opera");
        public static readonly Browser Empty = new Browser("Empty", InnerEnum.Empty, "No Browser");
        public static readonly Browser Mobile = new Browser("Mobile", InnerEnum.Mobile, "Mobile");

        private static readonly List<Browser> valueList = new List<Browser>();

        static Browser()
        {
            valueList.Add(Firefox);
            valueList.Add(Chrome);
            valueList.Add(IE);
            valueList.Add(Edge);
            valueList.Add(HtmlUnit);
            valueList.Add(Safari);
            valueList.Add(PhantomJS);
            valueList.Add(Opera);
            valueList.Add(Empty);
            valueList.Add(Mobile);
        }

        public enum InnerEnum
        {
            Firefox,
            Chrome,
            IE,
            Edge,
            HtmlUnit,
            Safari,
            PhantomJS,
            Opera,
            Empty,
            Mobile
        }

        public readonly InnerEnum innerEnumValue;
        private readonly string nameValue;
        private readonly int ordinalValue;
        private static int nextOrdinal = 0;

        private readonly string browserValue;

        internal Browser(string name, InnerEnum innerEnum, string value)
        {
            browserValue = value;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        public string BrowserValue
        {
            get
            {
                return browserValue;
            }
        }

        public bool HeadLess
        {
            get
            {
                return this == HtmlUnit || this == PhantomJS || this == Empty;
            }
        }

        public override string ToString()
        {
            return BrowserValue;
        }

        public static Browser fromString(string browserName)
        {
            foreach (Browser browser in values())
            {
                if (browser.browserValue.Equals(browserName, StringComparison.OrdinalIgnoreCase))
                {
                    return browser;
                }
            }
            return Mobile;
        }

        public static List<string> ValuesAsList
        {
            get
            {
                List<string> browserList = new List<string>();
                foreach (Browser browser in values())
                {
                    if (!browser.Equals(Mobile))
                    {
                        browserList.Add(browser.BrowserValue);
                    }
                }
                return browserList;
            }
        }

        public static Browser[] values()
        {
            return valueList.ToArray();
        }

        public int ordinal()
        {
            return ordinalValue;
        }

        public static Browser valueOf(string name)
        {
            foreach (Browser enumInstance in Browser.valueList)
            {
                if (enumInstance.nameValue == name)
                {
                    return enumInstance;
                }
            }
            throw new System.ArgumentException(name);
        }
    }

}
