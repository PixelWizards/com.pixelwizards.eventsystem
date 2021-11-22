/*
 * Advanced C# Messenger, from here: http://wiki.unity3d.com/index.php/Advanced_CSharp_Messenger
 */

namespace PixelWizards.Shared.EventSystem
{
    public delegate void Callback();

    public delegate void Callback<T>(T arg1);

    public delegate void Callback<T, U>(T arg1, U arg2);

    public delegate void Callback<T, U, V>(T arg1, U arg2, V arg3);
}