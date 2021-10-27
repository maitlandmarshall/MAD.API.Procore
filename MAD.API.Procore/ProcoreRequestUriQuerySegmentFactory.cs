using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MAD.API.Procore
{
    public class ProcoreRequestUriQuerySegmentFactory
    {
        public IEnumerable<string> Create(ProcoreRequest request)
        {
            IEnumerable<PropertyInfo> requestParametersPropertyInfos = request.GetType()
                .GetProperties()
                .Where(y => y.GetCustomAttribute<RequestParameterAttribute>() != null);

            foreach (PropertyInfo pi in requestParametersPropertyInfos)
            {
                RequestParameterAttribute attr = pi.GetCustomAttribute<RequestParameterAttribute>();
                object rpValue = pi.GetValue(request);

                if (rpValue is null)
                    continue;

                string rpValueString;

                if (rpValue is bool)
                {
                    rpValueString = rpValue.ToString().ToLower();
                }
                else
                {
                    rpValueString = rpValue.ToString();
                }

                yield return $"{attr.ParameterName}={rpValueString}";
            }
        }
    }
}
