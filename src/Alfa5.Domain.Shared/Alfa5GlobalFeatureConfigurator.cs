﻿using Volo.Abp.GlobalFeatures;
using Volo.Abp.Threading;

namespace Alfa5;

public static class Alfa5GlobalFeatureConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
                /* You can configure (enable/disable) global features of the used modules here.
                 * Please refer to the documentation to learn more about the Global Features System:
                 * https://docs.abp.io/en/abp/latest/Global-Features
                 */

                GlobalFeatureManager.Instance.Modules.CmsKit(cmsKit =>
                {
                    cmsKit.EnableAll();
                });

                GlobalFeatureManager.Instance.Modules.CmsKitPro(cmsKitPro =>
                {
                    cmsKitPro.EnableAll();
                });
            });
    }
}
