// Created by iWeb 3.0.4 local-build-20160830

function writeMovie1()
{detectBrowser();if(windowsInternetExplorer)
{document.write('<object id="id10" classid="clsid:02BF25D5-8C17-4B23-BC80-D3488ABDDC6B" codebase="http://www.apple.com/qtactivex/qtplugin.cab" width="300" height="185" style="height: 185px; left: 400px; position: absolute; top: 270px; width: 300px; z-index: 1; "><param name="src" value="Media/WHITE%20LIGHT%20MOV.mov" /><param name="controller" value="true" /><param name="autoplay" value="false" /><param name="scale" value="tofit" /><param name="volume" value="100" /><param name="loop" value="false" /></object>');}
else if(isiPhone)
{document.write('<object id="id10" type="video/quicktime" width="300" height="185" style="height: 185px; left: 400px; position: absolute; top: 270px; width: 300px; z-index: 1; "><param name="src" value="Research_files/WHITE%20LIGHT%20MOV-1.jpg"/><param name="target" value="myself"/><param name="href" value="../Media/WHITE%20LIGHT%20MOV.mov"/><param name="controller" value="true"/><param name="scale" value="tofit"/></object>');}
else
{document.write('<object id="id10" type="video/quicktime" width="300" height="185" data="Media/WHITE%20LIGHT%20MOV.mov" style="height: 185px; left: 400px; position: absolute; top: 270px; width: 300px; z-index: 1; "><param name="src" value="Media/WHITE%20LIGHT%20MOV.mov"/><param name="controller" value="true"/><param name="autoplay" value="false"/><param name="scale" value="tofit"/><param name="volume" value="100"/><param name="loop" value="false"/></object>');}}
setTransparentGifURL('Media/transparent.gif');function applyEffects()
{var registry=IWCreateEffectRegistry();registry.registerEffects({shadow_0:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#000000',opacity:0.750000}),shadow_4:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#434343',opacity:0.750000}),shadow_2:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#000000',opacity:0.750000}),stroke_0:new IWEmptyStroke(),reflection_0:new IWReflection({opacity:0.50,offset:2.00}),shadow_1:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#000000',opacity:0.750000}),shadow_3:new IWShadow({blurRadius:10,offset:new IWPoint(4.2426,4.2426),color:'#000000',opacity:0.750000})});registry.applyEffects();}
function hostedOnDM()
{return false;}
function onPageLoad()
{loadMozillaCSS('Research_files/ResearchMoz.css')
adjustLineHeightIfTooBig('id1');adjustFontSizeIfTooBig('id1');adjustLineHeightIfTooBig('id2');adjustFontSizeIfTooBig('id2');adjustLineHeightIfTooBig('id3');adjustFontSizeIfTooBig('id3');adjustLineHeightIfTooBig('id4');adjustFontSizeIfTooBig('id4');adjustLineHeightIfTooBig('id5');adjustFontSizeIfTooBig('id5');adjustLineHeightIfTooBig('id6');adjustFontSizeIfTooBig('id6');adjustLineHeightIfTooBig('id7');adjustFontSizeIfTooBig('id7');adjustLineHeightIfTooBig('id8');adjustFontSizeIfTooBig('id8');adjustLineHeightIfTooBig('id9');adjustFontSizeIfTooBig('id9');fixupAllIEPNGBGs();Widget.onload();fixAllIEPNGs('Media/transparent.gif');IMpreload('Research_files','shapeimage_3','0');IMpreload('Research_files','shapeimage_3','1');IMpreload('Research_files','shapeimage_3','2');IMpreload('Research_files','shapeimage_3','3');IMpreload('Research_files','shapeimage_3','4');IMpreload('Research_files','shapeimage_3','5');IMpreload('Research_files','shapeimage_3','6');IMpreload('Research_files','shapeimage_3','7');applyEffects()}
function onPageUnload()
{Widget.onunload();}
