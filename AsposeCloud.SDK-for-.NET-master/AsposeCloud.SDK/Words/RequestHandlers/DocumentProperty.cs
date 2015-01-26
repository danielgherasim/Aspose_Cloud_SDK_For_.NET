﻿using System;

namespace Aspose.Cloud.Words
{
    public class DocumentProperty 
    {
        public DocumentProperty() { }

        /// <summary>
        /// Resource BuiltIn Property
        /// </summary>
        public Boolean BuiltIn { get; set; }

        /// <summary>
        /// Resource Name Property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Resource Value Property
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Link Response related to document properties
        /// <link href="http://api.aspose.com/v1.1/words/TestProperties.doc/documentProperties/Author" rel="self" />
        /// </summary>
        public LinkResponse link { get; set; }

        public DocumentProperty(string propName, string propValue)
        {
            Name = propName;
            Value = propValue;
        }
    }
}
