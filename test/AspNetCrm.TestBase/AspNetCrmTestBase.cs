﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace AspNetCrm
{
    /* All test classes are derived from this class, directly or indirectly.
     */
    public abstract class AspNetCrmTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }

        protected virtual void WithUnitOfWork(Action action)
        {
            WithUnitOfWork(new UnitOfWorkOptions(), action);
        }

        protected virtual void WithUnitOfWork(UnitOfWorkOptions options, Action action)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

                using (var uow = uowManager.Begin(options))
                {
                    action();

                    uow.Complete();
                }
            }
        }

        protected virtual Task WithUnitOfWorkAsync(Func<Task> func)
        {
            return WithUnitOfWorkAsync(new UnitOfWorkOptions(), func);
        }

        protected virtual async Task WithUnitOfWorkAsync(UnitOfWorkOptions options, Func<Task> action)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

                using (var uow = uowManager.Begin(options))
                {
                    await action();

                    await uow.CompleteAsync();
                }
            }
        }

        protected virtual TResult WithUnitOfWork<TResult>(Func<TResult> func)
        {
            return WithUnitOfWork(new UnitOfWorkOptions(), func);
        }

        protected virtual TResult WithUnitOfWork<TResult>(UnitOfWorkOptions options, Func<TResult> func)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

                using (var uow = uowManager.Begin(options))
                {
                    var result = func();
                    uow.Complete();
                    return result;
                }
            }
        }

        protected virtual Task<TResult> WithUnitOfWorkAsync<TResult>(Func<Task<TResult>> func)
        {
            return WithUnitOfWorkAsync(new UnitOfWorkOptions(), func);
        }

        protected virtual async Task<TResult> WithUnitOfWorkAsync<TResult>(UnitOfWorkOptions options, Func<Task<TResult>> func)
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

                using (var uow = uowManager.Begin(options))
                {
                    var result = await func();
                    await uow.CompleteAsync();
                    return result;
                }
            }
        }
    }
}
