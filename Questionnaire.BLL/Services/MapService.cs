using AutoMapper;
using System.Collections.Generic;

namespace Questionnaire.BLL.Services
{
    public class MapService
    {
        public List<N> Mapping<T, N>(IEnumerable<T> source)
            where T : class
            where N : class
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<T, N>()).CreateMapper();
            return mapper.Map<IEnumerable<T>, List<N>>(source);
        }
    }
}
