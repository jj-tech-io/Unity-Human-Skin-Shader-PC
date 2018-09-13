![SSS](SSS.png)
# Unity Separable Subsurface Scattering
## Features:
* Realtime Post-processing SSS effects(Separable SSS)
* Custom Shader supported(Replacement Command Buffer)
* Realtime color gradient calculations
## Guide:
* Add "SSSCamera.cs" on the main camera
* Add "SSSObject.cs" on the human model
* Transform the options until you are satisify with the effects.
* Please Do not use vertex displacement shader on human model!
* We provide Jitter and noise to keep the sample's smoothness, so we suggest to have Temporal Anti-Alias on your rendering camera (For example Unity's Post-Processing Stack).

## FAQ:
### What shader should I use during making my own character?
* You should use a shader with a Stencil{Ref 5...} in forward opaque pipeline to make sure that the post-processing component will use that mask.
* Then, we suggest that you should use standard specular lighting shader for your skin, in our experiment, the shader with Unity GGX specular looks better than the others.
### Why forward rendering path only?
* Currently, we are seeking for a better solution to use both custom lighting model and deferred shading, which is difficult because the GBuffers' data is limited. Even if we use scriptable rendering pipeline, GBuffer textures is still inefficient especially for high resolution screen. Also, some effects such as transmission, can only be used during forward pipeline.
### Can I make more improvement based on SSSSS?
* Of course you can, we are currently using Disney diffuse and GGX specular for direct light calculation, obviously it is not the best solution for human's skin rendering. You can definitely try some more lighting formula and compare them, the post-processing component is compatible.

## Comming Soon:
* Skin Transmission.
* Provide more High definition skin shaders with exciting features.
