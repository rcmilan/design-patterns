﻿using Domain.Base;
using Mediator.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.Mediators
{
    public class ConcreteMediator<T> : IMediator<T>
    {
        private List<BaseModel<T>> _models;

        public ConcreteMediator()
        {
            _models = new List<BaseModel<T>>();
        }

        public BaseModel<T> Read(BaseModel<T> model)
        {
            return model == null ? null : _models.FirstOrDefault(m => m.Id.Equals(model.Id));
        }

        public void Store(BaseModel<T> model)
        {
            _models.Add(model);
        }
    }
}
