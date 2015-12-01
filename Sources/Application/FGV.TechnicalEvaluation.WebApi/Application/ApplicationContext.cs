using System;
using System.Collections.Generic;
using System.Configuration;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Entities;
using FGV.TechnicalEvaluation.WebApi.Application.Configuration;

namespace FGV.TechnicalEvaluation.WebApi.Application
{
    /// <summary>
    /// Contexto da aplicação
    /// </summary>
    public class ApplicationContext : IApplicationContext
    {
        private ISorting[] _bookOrdenation;

        public ISorting[] BookOrdenation
        {
            get
            {
                if (_bookOrdenation == null)
                {
                    var sortings = new List<Sorting<Book>>();
                    var section = (SortingsSection)ConfigurationManager.GetSection("fgv/sortings");
                    foreach (SortingCollection collection in section.Sortings)
                    {
                        if (Type.GetType(collection.Type) == typeof(Book))
                        {
                            foreach (SortingElement sorting in collection)
                            {
                                sortings.Add(new Sorting<Book>
                                {
                                    ColumnName = sorting.Column,
                                    Ascending = sorting.Ascending
                                });
                            }
                            break;
                        }
                    }
                    _bookOrdenation = sortings.ToArray();
                }
                return _bookOrdenation;
            }
        }
    }
}