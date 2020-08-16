var SessionTimeout=function() {
    var e=function() {
        $.sessionTimeout( {
            title:"Session Timeout Notification", 
            message:"Your session is about to expire.", 
            keepAliveUrl:"", 
            redirUrl: '/Authentication/LockScreen', 
            logoutUrl: '/Authentication/LogOut', 
            warnAfter: 1800000, // miliSecond - Start counting when no touch screen - After 30 Mins
            redirAfter: 1860000, // miliSecond (redirAfter - warnAfter) => Show DialogBox - After 1 Min
            ignoreUserActivity:!0, 
            countdownMessage:"Redirecting in {timer}.", 
            countdownBar: !0
        }
        )
    };
    return {
        init:function() {
            e()
        }
    }
}

();
jQuery(document).ready(function() {
    SessionTimeout.init()
}
);