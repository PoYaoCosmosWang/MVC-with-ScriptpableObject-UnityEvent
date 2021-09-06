# MVC-with-ScriptpableObject-UnityEvent
combining MVC model in unity with scriptableObject event  
This project is a demo for implementing MVC model in Unity with ScriptableObject events.  
The reference for MVC model in Unity is here:https://www.youtube.com/watch?v=dArGuJmFkEo   
The problem is that the eventBus is only a collection of events. Also, we cannot cateogrize these events.  
To handle this, I refer to ScriptableObject with events in this video:https://www.youtube.com/watch?v=raQ3iHhE_Kk  
After using ScriptableObject, we can manage our events in the folders, making it more accessible.  
What's more, the eventBus can be removed from the original design.  
EventHandlers can listen to the events in folders by themselves.  
  
In the future, maybe I can build a template version for this kind of event.   
