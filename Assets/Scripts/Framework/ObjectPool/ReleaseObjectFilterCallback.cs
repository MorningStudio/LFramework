﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorningStudio
{
    /// <summary>
    /// 释放对象筛选函数。
    /// </summary>
    /// <typeparam name="T">对象类型。</typeparam>
    /// <param name="candidateObjects">要筛选的对象集合。</param>
    /// <param name="toReleaseCount">需要释放的对象数量。</param>
    /// <param name="expireTime">对象过期参考时间。</param>
    /// <returns>经筛选需要释放的对象集合。</returns>
    public delegate LinkedList<T> ReleaseObjectFilterCallback<T>(LinkedList<T> candidateObjects, int toReleaseCount, DateTime expireTime) where T : ObjectBase;
}
