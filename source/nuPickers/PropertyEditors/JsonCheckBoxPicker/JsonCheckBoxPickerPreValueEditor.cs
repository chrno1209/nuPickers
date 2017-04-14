﻿namespace nuPickers.PropertyEditors.JsonCheckBoxPicker
{
    using nuPickers.EmbeddedResource;
    using Umbraco.Core.PropertyEditors;

    internal class JsonCheckBoxPickerPreValueEditor : PreValueEditor
    {
        [PreValueField("dataSource", "", EmbeddedResource.RootUrlPrefixed + "JsonDataSource/JsonDataSourceConfig.html", HideLabel = true)]
        public string DataSource { get; set; }

        [PreValueField("customLabel", "Label Macro", EmbeddedResource.RootUrlPrefixed + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [PreValueField("checkBoxPicker", "", EmbeddedResource.RootUrlPrefixed + "CheckBoxPicker/CheckBoxPickerConfig.html", HideLabel = true)]
        public string CheckBoxPicker { get; set; }

        [PreValueField("layoutDirection", "Layout Direction", EmbeddedResource.RootUrlPrefixed + "LayoutDirection/LayoutDirectionConfig.html")]
        public string LayoutDirection { get; set; }

        [PreValueField("relationMapping", "", EmbeddedResource.RootUrlPrefixed + "RelationMapping/RelationMappingConfig.html", HideLabel = true)]
        public string RelationMapping { get; set; }

        [PreValueField("saveFormat", "Save Format", EmbeddedResource.RootUrlPrefixed + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}