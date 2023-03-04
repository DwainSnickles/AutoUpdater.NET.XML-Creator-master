# AutoUpdater.NET XML Creator
This app is a component that creates custom xml file for Autoupdater.net.
Includes all tags optional.
At a minimum you need the first 2 tags
Xml tags are only added based on answers in wizard. 
Clicking next on any page without adding anything ignores the tag.

<code>
  
        <item>
        <version>2.1.0.0</version>
        <url>https://rbsoft.org/downloads/AutoUpdaterTest.zip</url>
        <changelog>https://github.com/ravibpatel/AutoUpdater.NET/releases</changelog>
        <checksum algorithm="MD5">b10a8db164e0754105b7a99be72e3fe5</checksum>
        <mandatory minversion="1.7.0.0">true</mandatory>
        </item>
  
 </code>

Includes all security tags optional.
Includes custom <mandatory> tag default = false

# Changes to come (TODO)
Create html file for releases this will be optional
Allow XML to be uploaded to server.
Create a user forum on my wesite http://sourcecodedepot.com/
Note above website is started but but far from ready.

# Others

View on NuGet: https://www.nuget.org/packages/AutoupdaterdotNet
