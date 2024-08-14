{ pkgs }: 
pkgs.mkShell {
  buildInputs = with pkgs; [
    # Add necessary packages here
    dotnetCorePackages.sdk_6_0  # Example for a .NET project
    git
    bash
    # You can add more packages as needed
  ];

  shellHook = ''
    echo "Welcome to your Nix development environment!"
    # Add any additional setup commands here
  '';
}