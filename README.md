﻿Demo
```
            var AppId = "AppId";
            var SecretId = "SecretId";
            var SecretKey = "SecretKey";
            var BucketName = "BucketName";
            var Region = "gz";

            var client = new CosCloud(int.Parse(AppId), SecretId, SecretKey, Region);
            var result = client.Upload(BucketName, "test.png", @"C:\Users\gool\Pictures\art5060340083.jpg.resize.png");
```

nuget  https://www.nuget.org/packages/Unreal.QCloud/