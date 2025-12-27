var UnoAppManifest = {
    displayName: "figma_design_system_uno",
    
    splashScreenColor: "#FFFFFF",
    
    // Add CSS to make app full screen
    environmentVariables: {},
    
    // Inject styles to make the app take full viewport
    styleContent: `
        html, body {
            margin: 0;
            padding: 0;
            width: 100vw;
            height: 100vh;
            overflow: hidden;
        }
        
        #uno-body {
            width: 100%;
            height: 100%;
        }
    `
}
