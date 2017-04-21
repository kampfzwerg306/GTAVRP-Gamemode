﻿/// <reference path="../../types-gtanetwork/index.d.ts" />

var myBrowser = null;
API.onServerEventTrigger.connect((eventName, args) => {
    switch (eventName) {
        case 'bag_showmanager':
            var res = API.getScreenResolution();
            myBrowser = API.createCefBrowser(200, 550);
            API.waitUntilCefBrowserInit(myBrowser);
            API.setCefBrowserPosition(myBrowser, (res.Width / 2) - (200 / 2),
                (res.Height / 2) - (550 / 2));
            API.loadPageCefBrowser(myBrowser, "inventory/bags/managebag.html");
            API.showCursor(true);

            //Send to fill items.
            myBrowser.call("fillItems", args[0], args[1]);
            break;
    }
});