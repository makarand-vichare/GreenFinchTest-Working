// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ControllerConvention.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace CodingTest.WebApi2.DependencyResolution
{
    using System;
    using System.Web.Mvc;
    using StructureMap.Graph;
    using StructureMap.Pipeline;
    using StructureMap.TypeRules;
    using StructureMap;
    using StructureMap.Graph.Scanning;
    using System.Linq;

    public class ControllerConvention : IRegistrationConvention {
        #region Public Methods and Operators

        public void Process(Type type, Registry registry) {
            if (type.CanBeCastTo<Controller>() && !type.IsAbstract) {
                registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
            }
        }

        public void ScanTypes(TypeSet types, Registry registry)
        {
            types.FindTypes(TypeClassification.Concretes | TypeClassification.Closed).ToList().ForEach(type =>
            {
                // Register against all the interfaces implemented
                // by this concrete class
                type.GetInterfaces().ToList().ForEach(@interface => registry.For(@interface).Use(type));
            });
        }

        #endregion
    }
}