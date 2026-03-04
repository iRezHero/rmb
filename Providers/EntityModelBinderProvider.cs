
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace irezhero.Database.Utilities
{
    public class EntityModelBinderProvider
     : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var modelType = context.Metadata.ModelType;

            if (typeof(IEntity).IsAssignableFrom(modelType) && !modelType.IsAbstract)
            {
                var binderType = typeof(EntityModelBinder<>).MakeGenericType(modelType);
                return new BinderTypeModelBinder(binderType);
            }
            return null;
        }
    }
}