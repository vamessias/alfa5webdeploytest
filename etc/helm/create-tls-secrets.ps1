﻿param (
    $Namespace="alfa5-local",
    $User = ""
)

$BaseNamespace = $Namespace
if([string]::IsNullOrEmpty($User) -eq $false)
{
    $Namespace += '-' + $User
}

mkcert --cert-file "${Namespace}.pem" --key-file "${Namespace}-key.pem" "${Namespace}"  "${Namespace}-authserver"  "${Namespace}-blazorwebapp"  "${Namespace}-httpapihost"   "${Namespace}-webpublic"  
kubectl create namespace ${Namespace}
kubectl create secret tls -n ${Namespace} ${BaseNamespace}-tls --cert=./${Namespace}.pem --key=./${Namespace}-key.pem