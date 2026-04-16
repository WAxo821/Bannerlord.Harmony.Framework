Bannerlord Harmony运行时补丁框架
项目概述：一个基于HarmonyLib的《骑马与砍杀2》轻量级运行时补丁项目，在不修改游戏源码的前提下，通过IL注入优化角色布娃娃系统物理效果，并实现参数可配置化
技术要点：
1.运行时补丁：精准挂钩Agent.SetVelocityLimitsOnRagdoll私有方法，覆写物理行为
2.Harmony集成：使用Harmony.PatchALL()实现干净可维护的IL注入
3.异常隔离：通过Prefix补丁安全修改LinearVelocityLimit参数，不干扰宿主程序执行
核心实现：通过反编译定位到目标方法后，使用Harmonyd的Prefix补丁在方法执行前拦截调用，利用ref参数直接修改调用栈上的数值：
[HarmonyPatch(typeof(Agent), "SetVelocityLimitsOnRagdoll")]
public static class RagdollVelocityPatch
{
    static void Prefix(Agent __instance, ref float linearVelocityLimit)
    {
        // 在游戏物理系统计算前，覆写速度限制参数
        linearVelocityLimit = 5f;
    }
}
技术选型说明：
1.为何用ref参数：直接在调用栈上修改参数值，无需入侵宿主原有逻辑，保证与游戏物理管线的兼容性
2.为何用prefix而非postfix：在原方法执行前完成参数覆写，避免无效计算，最小化性能开销，同时规避与后续逻辑的潜在冲突
项目演进：从硬编码到可配置化
v1.0：硬编码LinearVelocityLimit =5f（优化了游戏原版系统，但是用户无法根据偏好调整效果强度）
v2.0：参数外置至config,josn（实现轻量配置解析模块，用户无需重新编译即可自定义物理参数，同时降低了后续维护成本）

本项目作为个人技术作品，主要展现以下能力：
1.对闭源.NET应用程序的逆向分析与扩展
2.基于Harmony的清洁，可维护的C#补丁编码方式
3.项目迭代意识与配置化设计，理解软件工程中的解耦原则
