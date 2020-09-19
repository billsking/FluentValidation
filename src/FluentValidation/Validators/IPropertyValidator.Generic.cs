#region License
// Copyright (c) .NET Foundation and contributors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/FluentValidation/FluentValidation
#endregion

namespace FluentValidation.Validators {
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;
	using Resources;
	using Results;t

	/// <summary>
	/// A custom property validator.
	/// This interface should not be implemented directly in your code as it is subject to change.
	/// Please inherit from PropertyValidator instead.
	/// </summary>
	public interface IPropertyValidator<T,TProperty> : IPropertyValidator {
		/// <summary>
		/// Performs validation
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		IEnumerable<ValidationFailure> Validate(PropertyValidatorContext<T,TProperty> context);

		/// <summary>
		/// Performs validation asynchronously.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="cancellation"></param>
		/// <returns></returns>
		Task<IEnumerable<ValidationFailure>> ValidateAsync(PropertyValidatorContext<T,TProperty> context, CancellationToken cancellation);

		/// <summary>
		/// Determines whether this validator should be run asynchronously or not.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		bool ShouldValidateAsynchronously(IValidationContext context);

		/// <summary>
		/// Additional options for configuring the property validator.
		/// </summary>
		PropertyValidatorOptions<T,TProperty> Options { get; }
	}
}
