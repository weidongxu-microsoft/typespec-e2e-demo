// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Getitdone;

namespace Getitdone.Models
{
    /// <summary></summary>
    public partial class TodoItem : IJsonModel<TodoItem>
    {
        internal TodoItem()
        {
        }

        void IJsonModel<TodoItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoItem)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("creator_id"u8);
            writer.WriteStringValue(CreatorId);
            writer.WritePropertyName("created_at"u8);
            writer.WriteStringValue(CreatedAt);
            writer.WritePropertyName("assignee_id"u8);
            writer.WriteStringValue(AssigneeId);
            writer.WritePropertyName("assigner_id"u8);
            writer.WriteStringValue(AssignerId);
            writer.WritePropertyName("comment_count"u8);
            writer.WriteNumberValue(CommentCount);
            writer.WritePropertyName("is_completed"u8);
            writer.WriteBooleanValue(IsCompleted);
            writer.WritePropertyName("content"u8);
            writer.WriteStringValue(Content);
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            if (Optional.IsDefined(Due))
            {
                writer.WritePropertyName("due"u8);
                writer.WriteObjectValue(Due, options);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("labels"u8);
            writer.WriteStartArray();
            foreach (string item in Labels)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("order"u8);
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("project_id"u8);
            writer.WriteStringValue(ProjectId);
            if (Optional.IsDefined(SectionId))
            {
                writer.WritePropertyName("section_id"u8);
                writer.WriteStringValue(SectionId);
            }
            if (Optional.IsDefined(ParentId))
            {
                writer.WritePropertyName("parent_id"u8);
                writer.WriteStringValue(ParentId);
            }
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        TodoItem IJsonModel<TodoItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTodoItem(document.RootElement, options);
        }

        internal static TodoItem DeserializeTodoItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string creatorId = default;
            string createdAt = default;
            string assigneeId = default;
            string assignerId = default;
            int commentCount = default;
            bool isCompleted = default;
            string content = default;
            string description = default;
            Due due = default;
            string duration = default;
            string id = default;
            IList<string> labels = default;
            int order = default;
            int priority = default;
            string projectId = default;
            string sectionId = default;
            string parentId = default;
            string url = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("creator_id"u8))
                {
                    creatorId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("created_at"u8))
                {
                    createdAt = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("assignee_id"u8))
                {
                    assigneeId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("assigner_id"u8))
                {
                    assignerId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("comment_count"u8))
                {
                    commentCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("is_completed"u8))
                {
                    isCompleted = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("content"u8))
                {
                    content = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("description"u8))
                {
                    description = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("due"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    due = Due.DeserializeDue(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("duration"u8))
                {
                    duration = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("labels"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    labels = array;
                    continue;
                }
                if (prop.NameEquals("order"u8))
                {
                    order = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("priority"u8))
                {
                    priority = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("project_id"u8))
                {
                    projectId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("section_id"u8))
                {
                    sectionId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("parent_id"u8))
                {
                    parentId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("url"u8))
                {
                    url = prop.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new TodoItem(
                creatorId,
                createdAt,
                assigneeId,
                assignerId,
                commentCount,
                isCompleted,
                content,
                description,
                due,
                duration,
                id,
                labels,
                order,
                priority,
                projectId,
                sectionId,
                parentId,
                url,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<TodoItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TodoItem)} does not support writing '{options.Format}' format.");
            }
        }

        TodoItem IPersistableModel<TodoItem>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeTodoItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TodoItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TodoItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="todoItem"> The <see cref="TodoItem"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(TodoItem todoItem)
        {
            if (todoItem == null)
            {
                return null;
            }
            return BinaryContent.Create(todoItem, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="TodoItem"/> from. </param>
        public static explicit operator TodoItem(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeTodoItem(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
