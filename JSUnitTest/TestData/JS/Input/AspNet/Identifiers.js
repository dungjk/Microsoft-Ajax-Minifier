﻿function <%= prefix %>Root<%= suffix %>( foo )
{
    alert( foo< foo<%= Request("foo") %> );
}

function bar<%= this.ID %>(arf)
{
    return arf + <%= this.Arf %>;
}
