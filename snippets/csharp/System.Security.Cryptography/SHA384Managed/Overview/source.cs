﻿using System;
using System.Data;
using System.ComponentModel;
using System.Security.Cryptography;

public class Sample
{
 protected int DATA_SIZE = 1024;

 protected void Method()
 {
// <Snippet1>
byte[] data = new byte[DATA_SIZE];
byte[] result;

SHA384 shaM = new SHA384Managed();
result = shaM.ComputeHash(data);
// </Snippet1>
 }
}
