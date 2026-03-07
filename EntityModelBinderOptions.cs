// Copyright (c) Giancarlo Maniscalco. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace EntityModelBinder
{
    public class EntityModelBinderOptions
    {
        public bool EnableSwaggerSchemaIds { get; set; } = false;
        /// <summary>
        /// Set to true to suppress the automatic 400 response when model validation fails. 
        /// This allows you to handle validation errors manually in your controller actions.
        /// </summary>
        /// <remarks>
        /// When set to true, the ModelState will still be populated with validation errors, but the framework will not automatically return a 400 Bad Request response. 
        /// This is useful when you want to implement custom error handling logic in your controller actions, such as returning a different status code or a custom error response format.
        /// </remarks>
        public bool SuppressModelStateInvalidFilter { get; set; } = false;
        /// <summary>
        /// Configure the default database primary key column name.
        /// </summary>
        /// <remarks>
        /// If your database uses a different primary key column name than "Id", you can set it here. The model binder will assume this column name to query the database for the entity.
        /// </remarks>
        public string DefaultPrimaryKeyColumnName { get; set; } = "Id";
        /// <summary>
        /// Defines the default type used for primary keys.
        /// </summary>
        /// <remarks>The default value is <see cref="EntityKeyType.Int"/>, which specifies that integer primary keys are
        /// used unless another type is specified.
        /// </remarks>
        public EntityKeyType DefaultPrimaryKeyType { get; set; } = EntityKeyType.Int;
        public Action<MvcOptions>? ControllerConfiguration { get; set; }
    }
}
