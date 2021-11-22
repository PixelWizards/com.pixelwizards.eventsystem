# com.pixelwizards.eventsystem

## Advanced C# messenger 

A simple event Messenger broadcast / subscribe system for Unity.

Original Author: Ilya Suzdalnitski. V1.0

 http://wiki.unity3d.com/index.php/Advanced_CSharp_Messenger

Based on Rod Hyde's "CSharpMessenger" and Magnus Wolffelt's "CSharpMessenger Extended".

## Features:

 	    * Prevents a MissingReferenceException because of a reference to a destroyed message handler.
 	    * Option to log all messages
 	    * Extensive error detection, preventing silent bugs

##  Usage examples:

`Messenger.AddListener<GameObject>("prop collected", PropCollected);`

`Messenger.Broadcast<GameObject>("prop collected", prop);`

`Messenger.AddListener<float>("speed changed", SpeedChanged);`

`Messenger.Broadcast<float>("speed changed", 0.5f);`

Messenger cleans up its eventTable automatically upon loading of a new level.

Don't forget that the messages that should survive the cleanup, should be marked with:

`Messenger.MarkAsPermanent(string)`
